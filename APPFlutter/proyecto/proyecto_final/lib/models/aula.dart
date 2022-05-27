import 'horario.dart';

class Aulas{
List<Aula> items = [];
  Aulas();
  Aulas.fromJsonList(List<dynamic> jsonList) {
    if (jsonList == null) return;
    for (var item in jsonList) {
      final aula = new Aula.fromJsonMap(item);
      items.add(aula);
    }
  }
}

class Aula {
  int? idAula;
  String? nombre;
  List<Horario>? horarios;
  Aula(
    {
      this.idAula,
      this.nombre,
      this.horarios,
    }
  );

  Aula.fromJsonMap(Map<String, dynamic> json) {
    idAula = json['idAula'];
    nombre = json['nombre'];
    horarios = json['horario'];
       }

  Aula.fromJson(dynamic json) {
    idAula = json['idAula'];
    nombre = json['nombre'];
    horarios = json['horario'];   

  }

  int? getIdAula(){
    return idAula;
  }
  String? getNombre() {
    return nombre;
  }
  List<Horario>? getHorarios() {
    return horarios; 
  }
  String toString() {
    return "{" +
    "\"idAula\": $idAula "+
    ", \"nombre\": \"$nombre"'\"' +
    '}';
  }

  
}