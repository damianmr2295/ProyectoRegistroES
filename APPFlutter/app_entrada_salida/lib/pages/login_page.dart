// ignore_for_file: deprecated_member_use

import 'package:app_entrada_salida/models/user.dart';
import 'package:app_entrada_salida/pages/principal_page.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';

class loginPage extends StatefulWidget {
  @override
  State<loginPage> createState() => _loginPageState();
}

class _loginPageState extends State<loginPage> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body:
        cuerpo(context),
    );
  }
}

Widget cuerpo(BuildContext context) {
  final user = TextEditingController();
  final password = TextEditingController();

  return Container(
    decoration: const BoxDecoration(
        image: DecorationImage(
      image: NetworkImage(
          "https://alicanteplaza.es/public/Image/2021/4/231cf275f69d71fc28d0b7085776ce191_NoticiaAmpliada.jpg"),
      fit: BoxFit.fill,
    )),
    
    child: Center(
      child: Column(
        mainAxisAlignment: MainAxisAlignment.center,
        children: <Widget>[
          
          imagen(),
          const SizedBox(
            height: 70,
          ),
          nombre(),
          textUser(user),
          textPassword(password),
          const SizedBox(
            height: 50,
          ),
          botonEnter(context, user, password),
        ],
      ),
    ),
  );
}

Widget imagen() {
  return Image(
    image: NetworkImage(
        "https://portal.edu.gva.es/iesmarcoszaragoza/wp-content/uploads/sites/256/2021/04/cabecera-k-fondocolores2-nologos-cdc.png"),
  );
}

Widget nombre() {
  return const Text(
    "Sing in",
    style: TextStyle(
        color: Colors.blue,
        fontSize: 35,
        fontWeight: FontWeight.bold),
  );
}

Widget textUser(TextEditingController user) {
  return Container(
    padding: EdgeInsets.symmetric(horizontal: 15, vertical: 5),
    child: TextField(
      controller: user,
      decoration: const InputDecoration(
        hintText: "User (DNI)",
        fillColor: Colors.white,
        filled: true,
      ),
    ),
  );
}

Widget textPassword(TextEditingController password) {
  return Container(
    padding: EdgeInsets.symmetric(horizontal: 15, vertical: 5),
    child: TextField(
      controller: password,
      obscureText: true,
      decoration: const InputDecoration(
        hintText: "Password",
        fillColor: Colors.white,
        filled: true,
      ),
    ),
  );
}

Widget botonEnter(BuildContext context, TextEditingController user,
    TextEditingController password) {
      bool usuarioCorrecto = false;
      String? userNombre = "";
      String? userDni = "";
  return FlatButton(
      color: Colors.blueAccent,
      padding: const EdgeInsets.symmetric(horizontal: 100, vertical: 10),
      onPressed: () async {
        const String urlmain = '192.168.1.134:8080';
        const String urlPeticion = "/user/dni/";
        final url =
            Uri.http(urlmain, urlPeticion + "{dni}", {"dni": user.text});
        final resp = await http.get(url);

        if(resp.body.isNotEmpty){
        var decodedData = json.decode(resp.body);
        User usuario = User.fromJson(decodedData);
        usuarioCorrecto =
            comprobarUsuario(user.text, password.text, usuario.getPassword());
        userDni = usuario.getDni();
        userNombre = usuario.getNombre();
        }
        if (usuarioCorrecto) {
          Navigator.of(context).pushAndRemoveUntil(MaterialPageRoute<Null>(
            builder: (BuildContext context){
              return new principalPage(userNombre, userDni);
            }  
            ),(Route<dynamic> route) => false

          );
        } else {
          showDialog(
              context: context,
              builder: (BuildContext context) {
                return const AlertDialog(
                  title: Text("Usuario o contraseña incorrectos"),
                );
              });
        }
      },
      child: const Text(
        "Enter",
        style: TextStyle(fontSize: 25, color: Colors.white),
      ));
}

bool comprobarUsuario(String user, String password, String? pass) {
  if (password == pass) {
    return true;
  }
  return false;
}

  Widget _banner() {
    return (Image(
      image: AssetImage('assets/img/logotipo.png'),
    ));
  }
