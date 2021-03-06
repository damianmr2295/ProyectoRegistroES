import 'dart:convert';
import 'package:app_entrada_salida/models/ficha.dart';
import 'package:app_entrada_salida/models/horario.dart';
import 'package:app_entrada_salida/models/user.dart';
import 'package:http/http.dart' as http;
import 'package:intl/intl.dart';

class proyectoProvider {
  final String urlmain = '192.168.1.134:8080';

  Future<List<Ficha>> getinfoFichar() async {
    const String url_peticion = "/ficha/";
    final url = Uri.http(urlmain, url_peticion);
    final resp = await http.get(url);
    var decodedData = json.decode(resp.body);
    final listaFichas = Fichas.fromJsonList(decodedData);

    return listaFichas.items;
  }

  Future<List<Ficha>> getUltimaConexion(String fecha) async {
    const String urlPeticion = "/ficha/fecha/";
    final url = Uri.http(urlmain, urlPeticion + "{fecha}",  { "localDate" : fecha });
    final resp = await http.get(url);
    var decodedData = json.decode(resp.body);
    final listaFichas = Fichas.fromJsonList(decodedData);

    return listaFichas.items;
  }
  putFichar(Ficha ficha) async {
    var idFicha = ficha.getIdFicha();
    bool? est = ficha.getFichado();
    if (est!) {
      est = false;
    } else {
      est = true;
    }
    ficha.setFichado(est);
    ficha.setFecha(DateFormat('yyyy-MM-dd').format(DateTime.now()));
    final String url_peticion = "/ficha/modificar/$idFicha";
    final url = Uri.http(urlmain, url_peticion);
    await http.put(url,
        body: ficha.toString(),
        headers: {"Content-Type": "application/json"}).then((response) {
      Map<String, dynamic> result = json.decode(response.body);
    });
  }
  Future<User> getUserDni(String? dni) async {
    const String urlPeticion = "/user/dni/";
    final url = Uri.http(urlmain, urlPeticion + "{dni}",  { "dni" : "$dni" });
    final resp = await http.get(url);
    var decodedData = json.decode(resp.body);
    final user = User.fromJson(decodedData);
    return user;
  }
  Future<List<Horario>> getHorarioDia(int dia) async {
    const String url_peticion = "/horario/diaSemana/";
    final url = Uri.http(urlmain, url_peticion+"{diaSemana}", {"diaSemana" : "$dia"});
    final resp = await http.get(url);
    var decodedData = json.decode(resp.body);
    final listaHorario = Horarios.fromJsonList(decodedData);

    return listaHorario.items;
  }


 Future<List<Ficha>> getFichasDiaHorario(int dia) async {
    const String url_peticion = "/horario/diaSemana/";
    final url = Uri.http(urlmain, url_peticion+"{diaSemana}", {"diaSemana" : "$dia"});
    final resp = await http.get(url);
    var decodedData = json.decode(resp.body);
    final listaHorario = Horarios.fromJsonList(decodedData);
    List<Horario>? horarios =  listaHorario.items;
    dynamic fichas = []; 


    for(var i = 0; i< horarios.length; i++) {

      int? x = horarios[i].getIdHorario(); 
      String urlPeticion = "/ficha/idHorario/$x";

      final urlFichas = Uri.http(urlmain, urlPeticion );
      final respFicha = await http.get(urlFichas);
      var decodedDataFicha = json.decode(respFicha.body);

      final listaFichas = Ficha.fromJson(decodedDataFicha);
    }

    dynamic devolverListFichas = getUltimaConexion(DateFormat('yyyy-MM-dd').format(DateTime.now()));

    return devolverListFichas;
  }
}
