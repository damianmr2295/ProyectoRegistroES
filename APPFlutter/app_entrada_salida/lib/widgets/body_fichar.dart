import 'dart:ui';
import 'package:app_entrada_salida/models/ficha.dart';
import 'package:intl/intl.dart';
import 'package:app_entrada_salida/models/horario.dart';
import 'package:app_entrada_salida/providers/horario_providers.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class bodyFichar extends StatefulWidget {
  @override
  State<bodyFichar> createState() {
    return bodyFicharPageState();
  }
}

class Statefichar extends State<bodyFichar> {
  List<String> listaString = ["HOLA", "MIERDA", "FUNCIONA"];

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
        title: 'App Fichar',
        home: Scaffold(
          appBar: AppBar(
            title: Text("Fichaje diario"),
          ),
          body: Column(
            children: listaString.map((e) => Fichar(e)).toList(),
          ),
          floatingActionButton: FloatingActionButton(
            child: Icon(Icons.add),
            onPressed: () {},
          ),
        ));
  }
}

class Fichar extends StatelessWidget {
  String fichar;
  Fichar(this.fichar);

  @override
  Widget build(BuildContext context) {
    return Card(
      child: Center(
        child: Text(fichar),
      ),
    );
  }
}

class bodyFicharPageState extends State<bodyFichar> {
  @override
  late List<dynamic> locmesas;
  var mesa = "";
  Widget build(BuildContext context) {
    return Scaffold(
      body: ListView(
        padding: EdgeInsets.symmetric(horizontal: 10, vertical: 2),
        children: [
          Divider(),
          Column(
            children: [
              Divider(),
              crearFicha(),
            ],
          ),
          Divider(),
        ],
      ),
    );
  }

  Widget crearFicha() {
    final barprovider = proyectoProvider();

    return FutureBuilder(
        future: barprovider.getinfoFichar(),
        builder: (BuildContext context, AsyncSnapshot<List> snapshot) {
          if (snapshot.hasData) {
            return _tarjetasmesas(snapshot.data!);
          } else {
            return const Center(
              child: CircularProgressIndicator(),
            );
          }
        });
  }

  Widget _tarjetasmesas(List<dynamic> fichado) {
    final barprovider = proyectoProvider();
    MaterialColor? colorest = Colors.red;
    DateTime now = DateTime.now();
    String fechaActual = DateFormat('yyyy-MM-dd').format(now);
    return Container(
      child: Column(
        children: [
          Container(
            child: ListView.builder(
                physics: const NeverScrollableScrollPhysics(),
                shrinkWrap: true,
                itemCount: fichado.length,
                itemBuilder: (BuildContext context, int index) {
                  bool est = fichado[index].getFichado();
                  String hora = fichado[index].getHorario().getHoraInicio();
                  hora += "/ " + fichado[index].getHorario().getHoraFin();
                  String fecha = fichado[index].getFecha();
                  String curso = fichado[index].getHorario().getCurso();
                  if (est) {
                    colorest = Colors.green;
                  } else {
                    colorest = Colors.red;
                  }
                  if (fecha == fechaActual) {
                    return Container(
                      padding: const EdgeInsets.fromLTRB(10, 10, 10, 0),
                      height: 60,
                      child: Card(
                          elevation: 10,
                          color: colorest,
                          child: GestureDetector(
                            onTap: () {
                              barprovider.putFichar(fichado[index]);
                            },
                            child: Text(
                              "$hora // $curso",
                              style: TextStyle(fontSize: 18),
                              textAlign: TextAlign.center,
                            ),
                          )),
                    );
                  }
                  return Container();
                }),
          ),
        ],
      ),
    );
  }
}
