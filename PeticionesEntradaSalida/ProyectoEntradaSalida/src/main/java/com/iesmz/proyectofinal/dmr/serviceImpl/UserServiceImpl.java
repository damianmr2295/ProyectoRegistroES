package com.iesmz.proyectofinal.dmr.serviceImpl;

import com.iesmz.proyectofinal.dmr.domain.User;
import com.iesmz.proyectofinal.dmr.repository.UserRepository;
import com.iesmz.proyectofinal.dmr.service.UserService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import javax.transaction.Transactional;
import java.util.List;
import java.util.Optional;
import java.util.Set;

@Service
@Transactional
public class UserServiceImpl implements UserService {
    @Autowired
    private UserRepository userRepository;

    @Override
    public Set<User> findAll() {
        return userRepository.findAll();
    }

    @Override
    public Optional<User> findById(long id) {
        return userRepository.findById(id);
    }

    @Override
    public User findByDni(String dni) {
        return userRepository.findByDni(dni);
    }

    @Override
    public List<User> findByNombre(String nombre) {
        return userRepository.findByNombre(nombre);
    }
}
