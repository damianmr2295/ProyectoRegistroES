package com.iesmz.proyectofinal.dmr.service;

import com.iesmz.proyectofinal.dmr.domain.Aula;

import java.util.Optional;
import java.util.Set;

public interface AulaService {

    Set<Aula> findAll();
    Optional<Aula> findById(long id);
    Set<Aula> findByNombre(String nombre);
    void deleteByIdAula(long idAula);


}
