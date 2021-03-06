package com.iesmz.proyectofinal.dmr.repository;

import com.iesmz.proyectofinal.dmr.domain.Aula;
import org.springframework.data.repository.CrudRepository;

import java.util.Optional;
import java.util.Set;

public interface AulaRepository  extends CrudRepository<Aula, Long> {
    Set<Aula> findAll();
    Optional<Aula> findById(long id);
    Aula findByNombre(String nombre);
    void deleteByIdAula(long idAula);

}
