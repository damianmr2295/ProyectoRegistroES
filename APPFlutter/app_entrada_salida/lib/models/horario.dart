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

  int? getIdHorario(){
    return this.idHorario;
  }
  String? getHoraInicio() {
    return this.horaInicio;
  }
  String? getHoraFin() {
    return this.horaFin;
  }
  String? getCurso(){
    return this.curso;
  }
}