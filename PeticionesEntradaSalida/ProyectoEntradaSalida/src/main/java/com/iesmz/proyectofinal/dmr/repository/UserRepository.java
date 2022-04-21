package com.iesmz.proyectofinal.dmr.repository;

import com.iesmz.proyectofinal.dmr.domain.User;
import org.springframework.data.repository.CrudRepository;

import java.util.List;
import java.util.Optional;
import java.util.Set;

public interface UserRepository extends CrudRepository<User, Long> {
    Set<User> findAll();
    Optional<User> findById(long id);
    User findByDni(String dni);
    List<User> findByNombre(String nombre);
}
