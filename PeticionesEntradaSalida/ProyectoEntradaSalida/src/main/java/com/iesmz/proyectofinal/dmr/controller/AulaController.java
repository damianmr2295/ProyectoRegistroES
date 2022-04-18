package com.iesmz.proyectofinal.dmr.controller;

import com.iesmz.proyectofinal.dmr.domain.Aula;
import com.iesmz.proyectofinal.dmr.exception.AulaNotFoundException;
import com.iesmz.proyectofinal.dmr.service.AulaService;
import io.swagger.v3.oas.annotations.Operation;
import io.swagger.v3.oas.annotations.media.Content;
import io.swagger.v3.oas.annotations.media.Schema;
import io.swagger.v3.oas.annotations.responses.ApiResponse;
import io.swagger.v3.oas.annotations.responses.ApiResponses;
import io.swagger.v3.oas.annotations.tags.Tag;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.Set;


@RestController
@Tag(name = "Aula", description = "Catálogo de aulas")
public class AulaController {
    @Autowired
    private AulaService aulaService;

    @Operation(summary="Obtiene un aula por su Id")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "600", description = "El aula existe",
                    content = @Content(schema = @Schema(implementation =
                            Aula.class))),
            @ApiResponse(responseCode = "604", description = "El aula no existe",
                    content = @Content(schema = @Schema(implementation =
                            Aula.class)))
    })
    @GetMapping( value = "/aula/{id}", produces = "application/json")
    public ResponseEntity<Aula> getAula(@PathVariable long id) {

        Aula aula = aulaService.findById(id)
                .orElseThrow(() -> new AulaNotFoundException(id));
        return new ResponseEntity<Aula>(aula, HttpStatus.OK);
    }

    @Operation(summary = "Obtiene todas las aulas")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "600", description = "El aula existe",
                    content = @Content(schema = @Schema(implementation =
                            Aula.class))),
            @ApiResponse(responseCode = "604", description = "El aula no existe",
                    content = @Content(schema = @Schema(implementation =
                            Aula.class)))
    })
    @GetMapping( value = "/aula", produces = "application/json")
    public ResponseEntity<Set<Aula>> getAllAula() {
        Set<Aula> aula=null;
        aula = aulaService.findAll();
        return new ResponseEntity<>(aula, HttpStatus.OK);
    }
    @Operation(summary = "Elimina un aula por su id")
    @ApiResponses(value = {
            @ApiResponse(responseCode = "200", description = "Existe el aula con ese codMesa", content = @Content(schema = @Schema(implementation =
                    Aula.class))),
            @ApiResponse(responseCode = "404", description = "El aula no existe", content = @Content(schema = @Schema(implementation =
                    Response.class)))
    })

    @DeleteMapping("/borrar/aula/{idAula}")
    public ResponseEntity<com.iesmz.proyectofinal.dmr.controller.Response> deleteComanda(@PathVariable long idAula) {
        aulaService.deleteByIdAula(idAula);
        return new ResponseEntity<>(com.iesmz.proyectofinal.dmr.controller.Response.noErrorResponse(), HttpStatus.OK);
    }


}
