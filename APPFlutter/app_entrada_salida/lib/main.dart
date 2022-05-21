import 'package:app_entrada_salida/pages/login_page.dart';
import 'package:app_entrada_salida/pages/principal_page.dart';
import 'package:flutter/material.dart';

void main() => runApp(MyApp());

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
        debugShowCheckedModeBanner: false,
        title: 'AppEntradaSalida',
        initialRoute: 'login_page',
        routes: {
          'login_page': (BuildContext context) => loginPage(),
          'principal_page': (BuildContext context) => principalPage(),

        });
  }
}