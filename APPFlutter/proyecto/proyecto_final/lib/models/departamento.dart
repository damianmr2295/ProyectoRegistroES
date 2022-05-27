class Departamentos {
  List<Departamento> items = [];
  Departamentos();
  Departamentos.fromJsonList(List<dynamic> jsonList) {
    if (jsonList == null) return;
    for (var item in jsonList) {
      final departamento = new Departamento.fromJsonMap(item);
      items.add(departamento);
    }
  }
}

class Departamento {
  int? idDepartamento;
  String? nombre;
  Departamento({
    this.idDepartamento,
    this.nombre,
  });

  Departamento.fromJsonMap(Map<String, dynamic> json) {
    idDepartamento = json['idDepartamento'];
    nombre = json['nombre'];
  }
  Departamento.fromJson(dynamic json) {
    idDepartamento = json['idDepartamento'];
    nombre = json['nombre'];
  }
  int? getIdDepartamento() {
    return idDepartamento;
  }

  String? getNombre() {
    return nombre;
  }

  String toString() {
    return "{" +
        "\"idDepartamento\": $idDepartamento " +
        ", \"nombre\": \"$nombre" '\"' +
        '}';
  }
}
