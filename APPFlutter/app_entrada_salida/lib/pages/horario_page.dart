import 'package:app_entrada_salida/models/ficha.dart';
import 'package:app_entrada_salida/pages/principal_page.dart';
import 'package:app_entrada_salida/widgets/card/flecha_card.dart';
import 'package:app_entrada_salida/providers/proyecto_providers.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';


class HorarioPage extends StatefulWidget {
  String? usuario;
  DateTime? fechaHorario;
  String? dni;
  HorarioPage(this.usuario, this.fechaHorario, this.dni);
  @override
  State<HorarioPage> createState() {
    return bodyHorarioPageState();
  }
}
class bodyHorarioPageState extends State<HorarioPage> {
 @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        centerTitle: true,
        flexibleSpace: Container(
          decoration: const BoxDecoration(
            image: DecorationImage(image: NetworkImage( "https://portal.edu.gva.es/iesmarcoszaragoza/wp-content/uploads/sites/256/2021/04/cabecera-k-fondocolores2-nologos-cdc.png"),
            fit: BoxFit.fill
            )
          ),
        ),
      ),
      body: ListView(
        padding: const EdgeInsets.symmetric(horizontal: 10, vertical: 2),
        children: [
          const Divider(),
          Column(
            children: [
              const Divider(),
              crearBodyFecha(),
              crearBody(widget.fechaHorario),
            ],
          ),
          const Divider(),
        ],
      ),
      floatingActionButton: FloatingActionButton(
        child: const Icon(Icons.home),
        onPressed: () {
          Navigator.of(context).pushAndRemoveUntil(
                      MaterialPageRoute<Null>(builder: (BuildContext context) {
                    return new principalPage(widget.usuario!, widget.dni!);
                  }), (Route<dynamic> route) => false);
        },
      ),
    );
  }

  Widget crearBody(DateTime? fechaHorario) {
    final fichasProvider = proyectoProvider();
    Future<List<Ficha>> fichas = fichasProvider.getinfoFichar();
    int fechaFlechas = 0;
    return FutureBuilder(
        future: fichas,
        builder: (BuildContext context, AsyncSnapshot<dynamic> snapshot) {
          if (snapshot.hasData) {
              return tarjetaFicha(snapshot.data!, fechaHorario);
          } else {
            return const Center(
              child: CircularProgressIndicator(),
            );
          }
        });
  }
  Widget tarjetaFicha(List<dynamic> fichas, DateTime? fechaHorario) {
  final fichasProvider = proyectoProvider();
    String fechaActual = DateFormat('yyyy-MM-dd').format(fechaHorario!);
    return Column(
      children: [
        ListView.builder(
            physics: const NeverScrollableScrollPhysics(),
            shrinkWrap: true,
            itemCount: fichas.length,
            itemBuilder: (BuildContext context, int index) {
              bool est = fichas[index].getFichado();
              String hora = fichas[index].getHorario().getHoraInicio();
              hora += "/ " + fichas[index].getHorario().getHoraFin();
              String fecha = fichas[index].getFecha();
              String curso = fichas[index].getHorario().getCurso();
              if(widget.usuario == fichas[index].getHorario().getUser()){
                if (fecha == fechaActual ) {
                  return fichasDiaria(fichasProvider, fichas, index, hora, curso);
                }
              }
              return Container();
            }),
      ],
    );
  }
  Container fichasDiaria(proyectoProvider fichasProvider, List<dynamic> fichado,
      int index, String hora, String curso) {
    return Container(
      padding: const EdgeInsets.fromLTRB(10, 10, 10, 0),
      height: 70,
      child: Card(
          elevation: 15,
          color: const Color.fromRGBO(30, 220, 220, 0.7),
          child: GestureDetector(
            child: Row(
              children: <Widget>[
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
Widget crearBodyFecha() {
    final fichasProvider = proyectoProvider();
    Future<List<Ficha>> fichas = fichasProvider.getinfoFichar();
    int fechaFlechas = 0;
    return FutureBuilder(
        future: fichas,
        builder: (BuildContext context, AsyncSnapshot<dynamic> snapshot) {
          if (snapshot.hasData) {
              return tarjetaFlecha(snapshot.data!);
          } else {
            return const Center(
              child: CircularProgressIndicator(),
            );
          }
        });
}
  Widget tarjetaFlecha(List<dynamic> fichas) {
    return Column(
      children: [
        ListView.builder(
            physics: const NeverScrollableScrollPhysics(),
            shrinkWrap: true,
            itemCount: 1,
            itemBuilder: (BuildContext context, int index) {
              return fechaHorario(fichas[index].getFecha());
            }),
      ],
    );
  }
  Container fechaHorario(String nombre) {
    return Container(
      padding: const EdgeInsets.fromLTRB(10, 10, 10, 0),
      height: 80,
      child: Card(
        child: GestureDetector(
          child: Table(children: [
            TableRow(
              children: [
                FlechaCard(
                  color: Colors.blue,
                  fecha: DateFormat('yyyy-MM-dd').format(widget.fechaHorario!),
                  usuario: widget.usuario!,
                  dni: widget.dni!,
                ),
              ],
            ),
          ]),
      )),
    );
  }
}