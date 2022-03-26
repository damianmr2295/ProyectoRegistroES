package com.iesmz.proyectofinal.dmr.domain;

import io.swagger.v3.oas.annotations.media.Schema;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.persistence.*;
import javax.validation.constraints.NotBlank;
import java.time.LocalDate;

@Data
@AllArgsConstructor
@NoArgsConstructor
@Entity(name = "User")
public class User {


    @Schema(description = "DNI del trabajador/usuario", example = "78965428N", required = true)
    @Id
    private String dni;

    @Schema(description = "id del trabajador/usuario", example ="00001", required = true)
    @NotBlank
    @Column
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @Schema(description = "Nombre del trabajador/usuario", example ="Pepe", required = true)
    @NotBlank
    @Column
    private String nombre;

    @Schema(description = "Apellidos del trabajador/usuario", example ="Rodriguez Garcia", required = true)
    @NotBlank
    @Column
    private String apellidos;

    @Schema(description = "Contraseña del trabajador/usuario", example ="Contraseña55", required = true)
    @NotBlank
    @Column
    private String password;
}
