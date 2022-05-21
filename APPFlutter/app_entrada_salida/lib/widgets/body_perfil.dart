import 'package:app_entrada_salida/models/ficha.dart';
import 'package:app_entrada_salida/models/user.dart';
import 'package:app_entrada_salida/widgets/single_card.dart';
import 'package:app_entrada_salida/widgets/top_card.dart';
import 'package:app_entrada_salida/widgets/user_card.dart';
import 'package:intl/intl.dart';
import 'package:app_entrada_salida/providers/horario_providers.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';


class bodyPerfil extends StatefulWidget {
  String? userDni;
  bodyPerfil(this.userDni);
  @override
  State<bodyPerfil> createState() {
    return bodyPerfilPageState();
  }
}

class bodyPerfilPageState extends State<bodyPerfil> {
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
    final userProvider = proyectoProvider();
    Future<User> user = userProvider.getUserDni(widget.userDni);
    return FutureBuilder(
        future: user,
        builder: (BuildContext context, AsyncSnapshot<dynamic> snapshot) {
          if (snapshot.hasData) {
            return tarjetaFicha(snapshot.data!);
          } else {
            return const Center(
              child: CircularProgressIndicator(),
            );
          }
        });
  }

  Widget tarjetaFicha(dynamic user) {
    return Column(
      children: [
        ListView.builder(
            physics: const NeverScrollableScrollPhysics(),
            shrinkWrap: true,
            itemCount: 3,
            itemBuilder: (BuildContext context, int index) {
              if (index == 0) {
                return nombreUser(user.getNombre());
              } else if (index == 1) {
                return apellidoUser(user.getApellidos());
              } else {
                return horario();
              }
            }),
      ],
    );
  }

  Container nombreUser(String nombre) {
    return Container(
      padding: const EdgeInsets.fromLTRB(10, 10, 10, 0),
      height: 80,
      child: Card(
          child: GestureDetector(
        child: Table(children: [
          TableRow(
            children: [
              UserCard(
                color: Colors.blue,
                icon: Icons.person_outline_outlined,
                text: '  Nombre: $nombre',
              ),
            ],
          ),
        ]),
      )),
    );
  }

  Container apellidoUser(String apellidos) {
    return Container(
      padding: const EdgeInsets.fromLTRB(10, 10, 10, 0),
      height: 80,
      child: Card(
          child: GestureDetector(
        child: Table(children: [
          TableRow(
            children: [
              UserCard(
                color: Colors.blue,
                icon: Icons.wifi_tethering,
                text: '  Apellidos:  $apellidos',
              ),
            ],
          ),
        ]),
      )),
    );
  }

  Container horario() {
    return Container(
      padding: const EdgeInsets.fromLTRB(10, 10, 10, 0),
      height: 80,
      child: Card(
          child: GestureDetector(
        child: Table(children: const [
          TableRow(
            children: [
              UserCard(
                color: Colors.blue,
                icon: Icons.wifi_tethering,
                text: '  Cerrar sesion',
              ),
            ],
          ),
        ]),
      )),
    );
  }
}
