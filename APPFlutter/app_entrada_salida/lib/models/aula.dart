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
  List<Horario>? horario;
  Aula(
    {
      this.idAula,
      this.nombre,
      this.horario,
    }
  );

  Aula.fromJsonMap(Map<String, dynamic> json) {
    idAula = json['idAula'];
    nombre = json['nombre'];
    horario = json['horario'];
  }



  
}

