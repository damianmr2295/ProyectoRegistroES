package com.iesmz.proyectofinal.dmr.repository;

import com.iesmz.proyectofinal.dmr.domain.Departamento;
import org.springframework.data.repository.CrudRepository;

import java.util.Optional;
import java.util.Set;

public interface DepartamentoRepository extends CrudRepository<Departamento, Long> {
    Set<Departamento> findAll();
    Optional<Departamento> findById(long id);
    Set<Departamento> findByNombre(String nombre);

}
