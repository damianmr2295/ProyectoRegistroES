import 'dart:ui';
import 'package:intl/intl.dart';
import 'package:app_entrada_salida/providers/horario_providers.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class bodyFichar extends StatefulWidget {
  @override
  State<bodyFichar> createState() {
    return bodyFicharPageState();
  }
}

class bodyFicharPageState extends State<bodyFichar> {
  @override
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
    final fichasProvider = proyectoProvider();

    return FutureBuilder(
        future: fichasProvider.getinfoFichar(),
        builder: (BuildContext context, AsyncSnapshot<List> snapshot) {
          if (snapshot.hasData) {
            return _tarjetaFicha(snapshot.data!);
          } else {
            return const Center(
              child: CircularProgressIndicator(),
            );
          }
        });
  }

  Widget _tarjetaFicha(List<dynamic> fichado) {
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
                              setState(() {
                                barprovider.putFichar(fichado[index]);
                              });
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
