import 'package:app_entrada_salida/widgets/body_fichar.dart';
import 'package:app_entrada_salida/widgets/body_principal.dart';
import 'package:flutter/cupertino.dart';
import 'package:flutter/material.dart';

class principalPage extends StatefulWidget {
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
        title: const Text("IES MARCOS ZARAGOZA"),
        elevation: 0,
      ),
      body: PageView(
        controller: pageController,
        physics: NeverScrollableScrollPhysics(),
        children: [ 
        bodyPrincipal(),
        bodyFichar(),
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
        ],
      ),
    );
  }

  BottomNavigationBarItem pageFichar() {
    return const BottomNavigationBarItem(
          icon: Icon(Icons.drive_file_rename_outline_outlined),
          label: 'Fichar'
          );
  }

  BottomNavigationBarItem pagePrinci() {
    return const BottomNavigationBarItem(
          icon: Icon(Icons.home),
          label: 'Home'
          );
  }
}
class CustomScreeeen extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Container(
      color: Colors.blue,
      child: const Center(
        child: Text("pagina dos"),
      ),
    );
  }
}