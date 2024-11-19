import { actorPeliculaDto } from "../actores/actores.model";
import { cineDTO as cineDto } from "../cines/cines.model";
import { generoDto } from "../generos/generos.model";

export interface peliculaDto {
  id: number;
  titulo: string;
  poster: string;
  enCines: boolean;
  trailer: string;
  resumen?: string;
  fechaLanzamiento: Date;
  cines: cineDto[];
  generos: generoDto[];
  actores: actorPeliculaDto[];
  votoUsuario?: number;
  votoPromedio?: number;
}

export interface peliculaCreacionDto {
  titulo: string;
  enCines: boolean;
  trailer: string;
  resumen?: string;
  fechaLanzamiento?: Date;
  poster?: File;
  posterURL?: string;
  generosIds?: number[];
  cinesIds?: number[];
  actores?: actorPeliculaDto[];
}

export interface landingPageDto {
  enCines?: peliculaDto[];
  proximosEstrenos?: peliculaDto[];
}

export interface peliculasPostGetDto {
  generos: generoDto[];
  cines: cineDto[];
}

export interface peliculasPutGetDto{
  pelicula: peliculaDto;
  generosSeleccionados: generoDto[];
  generosNoSeleccionados: generoDto[];
  cinesSeleccionados: cineDto[];
  cinesNoSeleccionados: cineDto[];
  actores: actorPeliculaDto[]
}