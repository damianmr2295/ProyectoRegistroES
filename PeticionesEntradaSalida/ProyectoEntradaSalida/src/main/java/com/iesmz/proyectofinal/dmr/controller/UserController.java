package com.iesmz.proyectofinal.dmr.controller;

import com.iesmz.proyectofinal.dmr.domain.User;
import com.iesmz.proyectofinal.dmr.exception.UserNotFoundException;
import com.iesmz.proyectofinal.dmr.service.UserService;
import io.swagger.v3.oas.annotations.Operation;
import io.swagger.v3.oas.annotations.media.Content;
import io.swagger.v3.oas.annotations.media.Schema;
import io.swagger.v3.oas.annotations.responses.ApiResponse;
import io.swagger.v3.oas.annotations.responses.ApiResponses;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;

import java.util.Set;

public class UserController {

    @Autowired
    private UserService userService;

    @Operation(summary="Obtiene un User por su Id")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "600", description = "El User existe",
                    content = @Content(schema = @Schema(implementation =
                            User.class))),
            @ApiResponse(responseCode = "404", description = "El User no existe",
                    content = @Content(schema = @Schema(implementation =
                            User.class)))
    })
    @GetMapping( value = "/user/{id}", produces = "application/json")
    public ResponseEntity<User> getUser(@PathVariable long id) {

        User user = userService.findById(id)
                .orElseThrow(() -> new UserNotFoundException(id));
        return new ResponseEntity<User>(user, HttpStatus.OK);
    }

    @Operation(summary = "Obtiene todos los user")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "600", description = "El user existe",
                    content = @Content(schema = @Schema(implementation =
                            User.class))),
            @ApiResponse(responseCode = "404", description = "El user no existe",
                    content = @Content(schema = @Schema(implementation =
                            User.class)))
    })
    @GetMapping( value = "/user", produces = "application/json")
    public ResponseEntity<Set<User>> getAllUser() {
        Set<User> user=null;
        user = userService.findAll();
        return new ResponseEntity<>(user, HttpStatus.OK);
    }
}
