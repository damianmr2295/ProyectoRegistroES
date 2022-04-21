package com.iesmz.proyectofinal.dmr.controller;

import com.iesmz.proyectofinal.dmr.domain.Ficha;
import com.iesmz.proyectofinal.dmr.domain.User;
import com.iesmz.proyectofinal.dmr.exception.UserNotFoundException;
import com.iesmz.proyectofinal.dmr.service.UserService;
import io.swagger.v3.oas.annotations.Operation;
import io.swagger.v3.oas.annotations.media.Content;
import io.swagger.v3.oas.annotations.media.Schema;
import io.swagger.v3.oas.annotations.responses.ApiResponse;
import io.swagger.v3.oas.annotations.responses.ApiResponses;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.format.annotation.DateTimeFormat;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import java.time.LocalDate;
import java.util.List;
import java.util.Set;
@RestController
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
    @GetMapping( value = "/user/id/{id}", produces = "application/json")
    public ResponseEntity<User> getUser(@PathVariable long id) {

        User user = userService.findById(id)
                .orElseThrow(() -> new UserNotFoundException(id));
        return new ResponseEntity<User>(user, HttpStatus.OK);
    }
    @Operation(summary="Obtiene un usuario por su DNI")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "600", description = "El usuario existe",
                    content = @Content(schema = @Schema(implementation =
                            User.class))),
            @ApiResponse(responseCode = "404", description = "El usuario no existe",
                    content = @Content(schema = @Schema(implementation =
                            User.class)))
    })
    @GetMapping( value = "/user/dni/{dni}", produces = "application/json")
    public ResponseEntity<User> getUserDni(@RequestParam(value =
            "dni", defaultValue = "") String dni) {
        User user = null;
        if (!dni.equals(""))
            user = userService.findByDni(dni);
        return new ResponseEntity<>(user, HttpStatus.OK);
    }
    @Operation(summary="Obtiene un usuario por su nombre")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "600", description = "El usuario existe",
                    content = @Content(schema = @Schema(implementation =
                            User.class))),
            @ApiResponse(responseCode = "404", description = "El usuario no existe",
                    content = @Content(schema = @Schema(implementation =
                            User.class)))
    })
    @GetMapping( value = "/user/nombre/{nombre}", produces = "application/json")
    public ResponseEntity<List<User>> getUserNombre(@RequestParam(value =
            "nombre", defaultValue = "") String nombre) {

        List<User> users = null;
        users = userService.findByNombre(nombre);
        return new ResponseEntity<>(users, HttpStatus.OK);
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
