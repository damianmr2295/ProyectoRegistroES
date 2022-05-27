import 'package:app_entrada_salida/models/ficha.dart';
import 'package:app_entrada_salida/models/horario.dart';
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
              crearBody(),
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

  Widget crearBody() {
    final horarioProvider = proyectoProvider();
    Future<List<Horario>> horario = horarioProvider.getHorarioDia(widget.fechaHorario!.weekday);
    return FutureBuilder(
        future: horario,
        builder: (BuildContext context, AsyncSnapshot<dynamic> snapshot) {
          if (snapshot.hasData) {
              return tarjetaFicha(snapshot.data);
          } else {
            return const Center(
              child: CircularProgressIndicator(),
            );
          }
        });
  }
  Widget tarjetaFicha(List<dynamic> horario) {
    int hoyDia = widget.fechaHorario!.weekday;
    return Column(
      children: [
        ListView.builder(
            physics: const NeverScrollableScrollPhysics(),
            shrinkWrap: true,
            itemCount: horario.length,
            itemBuilder: (BuildContext context, int index) {
              String hora = horario[index].getHoraInicio()+ "/ " + horario[index].getHoraFin();
              String curso = horario[index].getCurso();
              int diaSemana = horario[index].getDiaSemana();

              if(widget.dni == horario[index].getUser()){
                if (hoyDia == diaSemana ) {
                  return fichasDiaria(index, hora, curso);
                }
              }
              return Container();
            }),
      ],
    );
  }
  Container fichasDiaria(int index, String hora, String curso) {
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
              return fechaHorario();
            }),
      ],
    );
  }
  Container fechaHorario() {
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