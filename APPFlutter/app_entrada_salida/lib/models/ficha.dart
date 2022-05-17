import 'horario.dart';
import 'dart:convert';

class Fichas{
List<Ficha> items = [];
  Fichas();
  Fichas.fromJsonList(List<dynamic> jsonList) {
    if (jsonList == null) return;
    for (var item in jsonList) {
      final ficha = new Ficha.fromJsonMap(item);
      items.add(ficha);
    }
  }
}

class Ficha {
  int? idFicha;
  String? fecha;
  bool? fichado;
  dynamic horario;
  Ficha(
    {
      this.idFicha,
      this.fecha,
      this.fichado,
      this.horario,
    }
  );

  Ficha.fromJsonMap(Map<String, dynamic> json) {
    idFicha = json['idFicha'];
    fecha = json['fecha'];
    fichado = json['fichado'];
    horario = json['horario'];
  }

  int? getIdFicha(){
    return idFicha;
  }
  String? getFecha() {
    return fecha;
  }
  bool? getFichado() {
    return fichado;
  }
  dynamic getHorario(){
    return horario;
  }
}