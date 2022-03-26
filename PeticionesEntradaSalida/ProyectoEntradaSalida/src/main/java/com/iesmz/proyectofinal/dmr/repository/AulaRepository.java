package com.iesmz.proyectofinal.dmr.repository;

import com.iesmz.proyectofinal.dmr.domain.Aula;
import com.iesmz.proyectofinal.dmr.domain.Departamento;
import org.springframework.data.repository.CrudRepository;

import java.util.Optional;
import java.util.Set;

public interface AulaRepository  extends CrudRepository<Aula, Long> {
    Set<Aula> findAll();
    Optional<Aula> findById(long id);
    Set<Aula> findByNombre(String nombre);
}
