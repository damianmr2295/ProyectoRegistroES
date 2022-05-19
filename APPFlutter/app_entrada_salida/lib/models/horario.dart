import 'package:app_entrada_salida/models/user.dart';

import 'aula.dart';

class Horarios{
List<Horario> items = [];
  Horarios();
  Horarios.fromJsonList(List<dynamic> jsonList) {
    if (jsonList == null) return;
    for (var item in jsonList) {
      final horario = new Horario.fromJsonMap(item);
      items.add(horario);
    }
  }
}

class Horario {
  int? idHorario;
  String? horaInicio;
  String? horaFin;
  int? diaSemana;
  Aula? aula;
  User? user;
  String? curso;
  Horario(
    {
      this.idHorario,
      this.horaInicio,
      this.diaSemana,
      this.horaFin,
      this.aula,
      this.curso,
      this.user,
    }
  );

  Horario.fromJsonMap(Map<String, dynamic> json) {
    idHorario = json['idHorario'];
    horaInicio = json['horaInicio'];
    diaSemana = json['diaSemana'];
    curso = json['curso'];
    horaFin = json['horaFin'];
    aula = json['aula'];
    user = json['user'];
  }
    Horario.fromJson(dynamic json) {
    idHorario = json['idHorario'];
    horaInicio = json['horaInicio'];
    diaSemana = json['diaSemana'];
    curso = json['curso'];
    horaFin = json['horaFin'];
    aula = (Aula.fromJson(json['aula']));
    user = (User.fromJson(json['user']));

  }

  int? getIdHorario(){
    return idHorario;
  }
  String? getHoraInicio() {
    return horaInicio;
  }
  String? getHoraFin() {
    return horaFin;
  }
  String? getCurso(){
    return curso;
  }
  int? getDiaSemana() {
    return diaSemana;
  }
  int? getAula() {
    return aula!.getIdAula();
  }
  String? getUser(){
    return user!.getNombre();
  }
  String toString() {
    return "{" +
    "\"idHorario\": $idHorario "+
    ", \"curso\": \"$curso"'\"' +
    ", \"diaSemana\": $diaSemana "+
    ", \"horaInicio\": \"$horaInicio"'\"' +
    ", \"horaFin\": \"$horaFin"'\"' +
    ", \"user\": "+ user.toString() +""'' +
    ", \"aula\": "+ aula.toString() +""'' +
    '}';
  }

}