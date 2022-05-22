import 'package:app_entrada_salida/models/user.dart';
import 'package:app_entrada_salida/pages/login_page.dart';
import 'package:app_entrada_salida/widgets/card/cerrar_sesion_card.dart';
import 'package:app_entrada_salida/widgets/card/user_card.dart';
import 'package:app_entrada_salida/providers/proyecto_providers.dart';
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
                return cerrarSesion();
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

  Container cerrarSesion() {
    return Container(
      padding: const EdgeInsets.fromLTRB(100, 10, 100, 0),
      height: 80,
      child: Card(
        color: const Color.fromRGBO(255, 255, 255, 1),
        shadowColor: Colors.white,
        child: GestureDetector(
          onTap:() {
                setState(() {
                    Navigator.of(context).pushAndRemoveUntil(MaterialPageRoute<Null>(
                      builder: (BuildContext context){
                        return loginPage();
                      }  
                    ),(Route<dynamic> route) => false

                  );
                });
              },
          child: Table(children: const [
            TableRow(
              children: [
                CerrarSesion(
                  text: '  Cerrar sesion',
                ),
              ],
            ),
          ]),
        )
      ),
    );
  }
}
