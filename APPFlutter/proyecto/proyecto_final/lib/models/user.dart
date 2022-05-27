
import 'departamento.dart';
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
  int? idUser;
  String? dni;
  String? nombre;
  String? apellidos;
  String? password;
  List <Horario>? horarios;
  Departamento? departamento; 
  User(
    {
      this.idUser,
      this.dni,
      this.nombre,
      this.apellidos,
      this.password,
      this.horarios,
    }
  );

  User.fromJsonMap(Map<String, dynamic> json) {
    idUser = json['idUser'];
    dni = json['dni'];
    nombre = json['nombre'];
    apellidos = json['apellidos'];
    password = json['password'];
    horarios = json['horario'];
    departamento= (Departamento.fromJson(json['departamento']));
  }
    User.fromJson(dynamic json) {
    idUser = json['idUser'];
    dni = json['dni'];
    nombre = json['nombre'];
    apellidos = json['apellidos'];
    password = json['password'];
    horarios = json['horario'];
    departamento= (Departamento.fromJson(json['departamento']));

  }
  int? getIdUser(){
    return idUser;
  }
  String? getDni() {
    return dni;
  }
  String? getNombre() {
    return nombre;
  }
  String? getApellidos() {
    return apellidos;
  }
  String? getPassword() {
    return password;
  }
  String toString() {
    return "{" +
    "\"idUser\": $idUser "+
    ", \"dni\": \"$dni"'\"' +
    ", \"nombre\": \"$nombre"'\"' +
    ", \"apellidos\": \"$apellidos"'\"' +
    ", \"password\": \"$password"'\"' +
    ", \"departamento\": "+ departamento.toString() +""'' +
    '}';
  }

}

