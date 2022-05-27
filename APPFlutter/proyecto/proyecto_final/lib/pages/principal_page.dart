import 'package:proyecto_final/widgets/body/body_fichar.dart';
import 'package:proyecto_final/widgets/body/body_home.dart';
import 'package:proyecto_final/widgets/body/body_perfil.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class principalPage extends StatefulWidget {
  String? userNombre;
  String? userDni;
  principalPage(this.userNombre, this.userDni);
  @override
  State<principalPage> createState() => _principalPageState();
}

class _principalPageState extends State<principalPage> {
  int index = 0;
  final PageController pageController = new PageController(initialPage: 0);

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
      body: PageView(
        controller: pageController,
        physics: NeverScrollableScrollPhysics(),
        children: [ 
        bodyHome(widget.userNombre, widget.userDni),
        bodyFichar(widget.userNombre),
        bodyPerfil(widget.userDni),
        ],
      ),
      bottomNavigationBar: BottomNavigationBar(
        currentIndex: index,
        onTap: (page){
          index = page;
          pageController.animateToPage(page, duration: Duration(milliseconds:300), curve: Curves.fastOutSlowIn);
          setState(() {});
        },
        backgroundColor: Colors.blue.withOpacity(0.5),
        selectedItemColor: Colors.white,
        unselectedItemColor: Colors.white.withOpacity(0.4),
        items: [
          pagePrinci(),
          pageFichar(),
          pagePerfil(),
        ],
      ),
    );
  }
  BottomNavigationBarItem pagePrinci() {
    return const BottomNavigationBarItem(
          icon: Icon(Icons.home),
          label: 'Home'
          );
  }
  BottomNavigationBarItem pageFichar() {
    return const BottomNavigationBarItem(
          icon: Icon(Icons.drive_file_rename_outline_outlined),
          label: 'Fichar'
          );
  }
  BottomNavigationBarItem pagePerfil() {
    return const BottomNavigationBarItem(
          icon: Icon(Icons.person),
          label: 'Perfil'
          );
  }

}