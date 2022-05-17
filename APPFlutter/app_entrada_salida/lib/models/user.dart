
import 'aula.dart';
import 'horario.dart';

class Users{
List<User> items = [];
  Users();
  Users.fromJsonList(List<dynamic> jsonList) {
    if (jsonList == null) return;
    for (var item in jsonList) {
      final user = new User.fromJsonMap(item);
      items.add(user);
    }
  }
}

class User {
  int? idAula;
  String? dni;
  String? nombre;
  String? apellidos;
  Aula? pasword;
  List <Horario>? horarios;
  User(
    {
      this.idAula,
      this.dni,
      this.nombre,
      this.apellidos,
      this.pasword,
      this.horarios,
    }
  );

  User.fromJsonMap(Map<String, dynamic> json) {
    idAula = json['idAula'];
    dni = json['dni'];
    nombre = json['nombre'];
    apellidos = json['apellidos'];
    pasword = json['pasword'];
    horarios = json['horarios'];
  }
}

