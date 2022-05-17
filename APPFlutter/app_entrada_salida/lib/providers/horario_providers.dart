import 'dart:convert';

import 'package:app_entrada_salida/models/ficha.dart';
import 'package:http/http.dart' as http;


class proyectoProvider {
  final String urlmain = '192.168.1.137:8080';

  Future<List<Ficha>> getinfoFichar() async {

    final String url_peticion = "/ficha/";
    final url = Uri.http(urlmain, url_peticion);
    final resp = await http.get(url);
    var decodedData = json.decode(resp.body);
    print(decodedData);

    final listaFichas = Fichas.fromJsonList(decodedData);

    return listaFichas.items;
  }





}
