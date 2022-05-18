import 'dart:convert';

import 'package:app_entrada_salida/models/ficha.dart';
import 'package:app_entrada_salida/models/horario.dart';
import 'package:http/http.dart' as http;


class proyectoProvider {
  final String urlmain = '192.168.1.137:8080';

  Future<List<Ficha>> getinfoFichar() async {

    final String url_peticion = "/ficha/";
    final url = Uri.http(urlmain, url_peticion);
    final resp = await http.get(url);
    var decodedData = json.decode(resp.body);
    //print(decodedData);
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

    final String url_peticion = "/ficha/modificar/$idFicha";
    final url = Uri.http(urlmain, url_peticion);
    print(ficha.toString());
    await http.put(
      url,
      body:        
        ficha.toString(),
        headers: {
          "Content-Type" : "application/json"
          }
      ).then((response) {
        Map<String, dynamic> result = json.decode(response.body);
        print(result);
      });

  }



  Future<List<Horario>> getHorario() async {
    final String url_peticion = "/horario";
    final url = Uri.http(urlmain, url_peticion);
    final resp = await http.get(url);
    final decodedData = json.decode(resp.body);
    print(decodedData);
    Horarios horarios = new Horarios.fromJsonList(decodedData);
    return horarios.items;
  }
}
