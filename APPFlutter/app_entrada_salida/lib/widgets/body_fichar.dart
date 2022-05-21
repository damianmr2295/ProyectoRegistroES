import 'dart:ui';
import 'package:intl/intl.dart';
import 'package:app_entrada_salida/providers/horario_providers.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

// ignore: camel_case_types
class bodyFichar extends StatefulWidget {
  @override
  State<bodyFichar> createState() {
    return bodyFicharPageState();
  }
}

// ignore: camel_case_types
class bodyFicharPageState extends State<bodyFichar> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: ListView(
        padding: const EdgeInsets.symmetric(horizontal: 10, vertical: 2),
        children: [
          const Divider(),
          Column(
            children: [
              const Divider(),
              crearFicha(),
            ],
          ),
          const Divider(),
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
            return tarjetaFicha(snapshot.data!);
          } else {
            return const Center(
              child: CircularProgressIndicator(),
            );
          }
        });
  }

  Widget tarjetaFicha(List<dynamic> fichado) {
    final fichasProvider = proyectoProvider();
    DateTime now = DateTime.now();
    String fechaActual = DateFormat('yyyy-MM-dd').format(now);
    return Column(
      children: [
        ListView.builder(
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
                if (fecha == fechaActual) {
                  return fichaTrue(fichasProvider, fichado, index, hora, curso);
                }
              } else {
                if (fecha == fechaActual) {
                  return fichaFalse(fichasProvider, fichado, index, hora, curso);
                }
              }
              return Container();
            }),
      ],
    );
  }

  Container fichaTrue(proyectoProvider fichasProvider, List<dynamic> fichado,
      int index, String hora, String curso) {
    return Container(
      padding: const EdgeInsets.fromLTRB(10, 10, 10, 0),
      height: 70,
      child: Card(
          elevation: 15,
          color: const Color.fromRGBO(30, 220, 220, 0.7),
          child: GestureDetector(
            onTap: () {
              setState(() {
                fichasProvider.putFichar(fichado[index]);
              });
            },
            child: Row(
              children: <Widget>[
                const Icon(Icons.check_box, color: Colors.green, size: 25),
                Text(
                  "  $hora // $curso",
                  style: const TextStyle(fontSize: 18),
                  textAlign: TextAlign.center,
                ),
              ],
            ),
          )),
    );
  }

  Container fichaFalse(proyectoProvider fichasProvider, List<dynamic> fichado,
      int index, String hora, String curso) {
    return Container(
      padding: const EdgeInsets.fromLTRB(10, 10, 10, 0),
      height: 70,
      child: Card(
          elevation: 15,
          color: const Color.fromRGBO(30, 220, 220, 0.7),
          child: GestureDetector(
            onTap: () {
              setState(() {
                fichasProvider.putFichar(fichado[index]);
              });
            },
            child: Row(
              children: <Widget>[
                const Icon(Icons.check_box_outline_blank,
                    color: Colors.red, size: 25),
                Text(
                  "  $hora // $curso",
                  style: const TextStyle(fontSize: 18),
                  textAlign: TextAlign.center,
                ),
              ],
            ),
          )),
    );
  }
}
