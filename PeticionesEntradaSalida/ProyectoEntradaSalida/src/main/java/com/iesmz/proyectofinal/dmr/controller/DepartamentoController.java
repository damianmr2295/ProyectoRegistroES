package com.iesmz.proyectofinal.dmr.controller;

import com.iesmz.proyectofinal.dmr.domain.Departamento;
import com.iesmz.proyectofinal.dmr.exception.DepartamentoNotFoundException;
import com.iesmz.proyectofinal.dmr.service.DepartamentoService;
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
import org.springframework.web.bind.annotation.RestController;

import java.util.Set;
@RestController
public class DepartamentoController {
    @Autowired
    private DepartamentoService departamentoService;

    @Operation(summary="Obtiene un departamento por su Id")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "600", description = "El Departamento existe",
                    content = @Content(schema = @Schema(implementation =
                            Departamento.class))),
            @ApiResponse(responseCode = "404", description = "El Departamento no existe",
                    content = @Content(schema = @Schema(implementation =
                            Departamento.class)))
    })
    @GetMapping( value = "/departamento/{id}", produces = "application/json")
    public ResponseEntity<Departamento> getDepartamento(@PathVariable long id) {

        Departamento departamento = departamentoService.findById(id)
                .orElseThrow(() -> new DepartamentoNotFoundException(id));
        return new ResponseEntity<Departamento>(departamento, HttpStatus.OK);
    }

    @Operation(summary = "Obtiene todos los departamentos")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "600", description = "El Departamento existe",
                    content = @Content(schema = @Schema(implementation =
                            Departamento.class))),
            @ApiResponse(responseCode = "404", description = "El Departamento no existe",
                    content = @Content(schema = @Schema(implementation =
                            Departamento.class)))
    })
    @GetMapping( value = "/departamento", produces = "application/json")
    public ResponseEntity<Set<Departamento>> getAllDepartamento() {
        Set<Departamento> departamento=null;
        departamento = departamentoService.findAll();
        return new ResponseEntity<>(departamento, HttpStatus.OK);
    }
}
