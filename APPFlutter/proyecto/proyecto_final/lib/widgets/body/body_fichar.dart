import 'dart:ui';
import 'package:proyecto_final/models/ficha.dart';
import 'package:intl/intl.dart';
import 'package:proyecto_final/providers/proyecto_providers.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class bodyFichar extends StatefulWidget {
  String? usuario;
  bodyFichar(this.usuario);
  @override
  State<bodyFichar> createState() {
    return bodyFicharPageState(usuario);
  }
}

class bodyFicharPageState extends State<bodyFichar> {
  String? usuario;
  bodyFicharPageState(this.usuario);
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
              DiaHoy(),
              crearFicha(),
            ],
          ),
          const Divider(),
        ],
      ),
    );
  }

  Widget DiaHoy() {
    final fichasProvider = proyectoProvider();
    Future<List<Ficha>> fichas = fichasProvider.getinfoFichar();
    return FutureBuilder(
        future: fichas,
        builder: (BuildContext context, AsyncSnapshot<List> snapshot) {
      if (snapshot.hasData) {
        return tarjetaDiaSemana(snapshot.data!);
      } else {
        return const Center(
          child: CircularProgressIndicator(),
        );
      }
    });
  }

  Widget tarjetaDiaSemana(List<dynamic> fichado) {
    DateTime dia = DateTime.now();
    int hoyDia = dia.weekday;
    return Column(
      children: [
        ListView.builder(
            physics: const NeverScrollableScrollPhysics(),
            shrinkWrap: true,
            itemCount: 1,
            itemBuilder: (BuildContext context, int index) {
              return Container(
                padding: const EdgeInsets.fromLTRB(50, 10, 50, 0),
                height: 50,
                child: Card(
                    child: GestureDetector(
                  child: Table(children: [
                    TableRow(
                      children: [
                        
                        Column(
                          mainAxisAlignment: MainAxisAlignment.center,
                          children: [
                            Row(
                              children: [
                                Text(
                                  "         " +
                                      DateFormat('yyyy-MM-dd')
                                          .format(DateTime.now()) +
                                      "        ",
                                  style: TextStyle(
                                      color: Colors.blue, fontSize: 25),
                                ),
                              ],
                            ),
                          ],
                        ),
                      ],
                    ),
                  ]),
                )),
              );
            }),
      ],
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
    DateTime dia = DateTime.now();
    int hoyDia = dia.weekday;
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
              int diaSemana = fichado[index].getHorario().getDiaSemana();
              String curso = fichado[index].getHorario().getCurso();
              if (usuario == fichado[index].getHorario().getUser()) {
                if (est) {
                  if (hoyDia == diaSemana) {
                    return fichaTrue(
                        fichasProvider, fichado, index, hora, curso);
                  }
                } else {
                  if (hoyDia == diaSemana) {
                    return fichaFalse(
                        fichasProvider, fichado, index, hora, curso);
                  }
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
