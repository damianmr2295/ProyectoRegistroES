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

/*
class _HomeBody extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return SingleChildScrollView(
      child: Column(children: [
        PageTitle(),
        //Card Table
        CardTable()
      ]),
    );
  }
}

class Background extends StatelessWidget {
  final boxDecoration = BoxDecoration(
      gradient: LinearGradient(
          begin: Alignment.topCenter,
          end: Alignment.bottomCenter,
          stops: [0.2, 0.8],
          colors: [Color(0xff00BCD4), Color(0xffB3E5FC)]));
  @override
  Widget build(BuildContext context) {
    return Stack(children: [
      Container(decoration: boxDecoration)
    ]);
  }
}

class CardTable extends StatelessWidget {
  const CardTable({Key? key}) : super(key: key);
  @override
  Widget build(BuildContext context) {
    return Table(children: [
      TableRow(children: [
        _SingleCard(
          color: Colors.blue,
          icon: Icons.border_all,
          text: 'Estado',
        ),]),
      TableRow(children: [
        _SingleCard(
          color: Colors.pinkAccent,
          icon: Icons.car_rental,
          text: 'Notificaciónes',
        ),
      ]),
      TableRow(children: [
        _SingleCard(
          color: Colors.purple,
          icon: Icons.border_all,
          text: 'Horario'),]),
      TableRow(children: [
        _SingleCard(
            color: Colors.purpleAccent,
            icon: Icons.cloud,
            text: 'Historial de fichajes'),
      ]),
    ]);
  }
}

class _SingleCard extends StatelessWidget {
  final IconData icon;
  final Color color;
  final String text;
  const _SingleCard(
      {Key? key, required this.icon, required this.color, required this.text})
      : super(key: key);
  @override
  Widget build(BuildContext context) {
    var column = Column(
      mainAxisAlignment: MainAxisAlignment.center,
      children: [
        CircleAvatar(
          backgroundColor: this.color,
          child: Icon(
            this.icon,
            size: 35,
          ),
          radius: 30,
        ),
        SizedBox(height: 15),
        Text(
          this.text,
          style: TextStyle(color: this.color, fontSize: 22),
        )
      ],
    );
    return _CardBackground(child: column);
  }
}

class _CardBackground extends StatelessWidget {
  final Widget child;
  const _CardBackground({Key? key, required this.child}) : super(key: key);
  @override
  Widget build(BuildContext context) {
    final boxDecoration = BoxDecoration(
        color: Color.fromRGBO(62, 66, 107, 0.7),
        borderRadius: BorderRadius.circular(20));
    return Container(
        margin: EdgeInsets.all(20),
        child: ClipRRect(
          borderRadius: BorderRadius.circular(20),
          child: BackdropFilter(
            filter: ImageFilter.blur(sigmaX: 5, sigmaY: 5),
            child: Container(
              height: 180,
              decoration: boxDecoration,
              child: this.child,
            ),
          ),
        ));
  }
}

class CustomBottomNavigation extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return BottomNavigationBar(
      showSelectedLabels: false,
      showUnselectedLabels: false,
      selectedItemColor: Colors.pink,
      backgroundColor: Color.fromRGBO(55, 57, 84, 1),
      unselectedItemColor: Color.fromRGBO(116, 117, 152, 1),
      currentIndex: 0,
      items: [
        BottomNavigationBarItem(
            icon: Icon(Icons.calendar_today_outlined), label: 'Calendar'),
        BottomNavigationBarItem(
            icon: Icon(Icons.supervised_user_circle_outlined), label: 'Users'),
      ],
    );
  }
}

class PageTitle extends StatelessWidget {
  Widget build(BuildContext context) {
    return SafeArea(

      child: Container(
        margin: EdgeInsets.symmetric(horizontal: 10, vertical: 20),
               child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [   
            Text(
              'IES Marcos Zaragoza',
              style: TextStyle(
                  fontSize: 22,
                  fontWeight: FontWeight.bold,
                  color: Colors.white),
            ),
            SizedBox(height: 10),
          ],
          
        ),
        
      ),
    );
  }
}
*/