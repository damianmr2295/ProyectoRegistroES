package com.iesmz.proyectofinal.dmr.service;

import com.iesmz.proyectofinal.dmr.domain.User;

import java.util.List;
import java.util.Optional;
import java.util.Set;

public interface UserService {
    Set<User> findAll();
    Optional<User> findById(long id);
    User findByDni(String dni);
    List<User> findByNombre(String nombre);
}
