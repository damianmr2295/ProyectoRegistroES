package com.iesmz.proyectofinal.dmr.domain;

import io.swagger.v3.oas.annotations.media.Schema;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.persistence.*;
import javax.validation.constraints.NotBlank;
import java.time.LocalDate;
import java.util.List;
import java.util.Set;

@Data
@AllArgsConstructor
@NoArgsConstructor
@Entity(name = "Horario")
public class Horario {

    @Schema(description = "Curso del horario", example = "2DAM", required = true)
    @Id
    private String curso;

    @Schema(description = "Fecha del horario", example ="26/05/2022", required = true)
    @NotBlank
    @Column
    private LocalDate fecha;

    @Schema(description = "Dia de la semanal del horario", example = "Viernes", required = true)
    @NotBlank
    @Column
    private String diaSemana;

    /*@Schema(description = "Hora de inicio del trabajador en el horario", example = "08:00h", required = true)
    @NotBlank
    @Column
    private List<String> horaInicio;

    @Schema(description = "Hora final del trabajador en el horario", example = "14:00h", required = true)
    @NotBlank
    @Column
    private List<String> horaFin;*/

    /*@Schema(description = "Fichaje del trabajador en el horario", example = "E08:00h S14:00h", required = true)
    @NotBlank
    @Column
    private Set<String> Fichado;*/

}
