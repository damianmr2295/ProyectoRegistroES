import 'dart:convert';
import 'package:proyecto_final/models/ficha.dart';
import 'package:proyecto_final/models/user.dart';
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

}
