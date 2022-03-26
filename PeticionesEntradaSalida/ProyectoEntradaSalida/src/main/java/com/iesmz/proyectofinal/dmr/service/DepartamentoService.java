package com.iesmz.proyectofinal.dmr.service;

import com.iesmz.proyectofinal.dmr.domain.Departamento;

import java.util.Optional;
import java.util.Set;

public interface DepartamentoService {

    Set<Departamento> findAll();
    Optional<Departamento> findById(long id);
    Set<Departamento> findByNombre(String nombre);
}
