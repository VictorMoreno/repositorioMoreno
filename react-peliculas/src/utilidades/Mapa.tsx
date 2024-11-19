import {
  MapContainer,
  Marker,
  Popup,
  TileLayer,
  useMapEvent,
} from "react-leaflet";
import L from "leaflet";
import icon from "leaflet/dist/images/marker-icon.png";
import iconShadow from "leaflet/dist/images/marker-shadow.png";
import "leaflet/dist/leaflet.css";
import { coordenadaDto } from "./coordenada.module";
import { useState } from "react";

let DefaultIcon = L.icon({
  iconUrl: icon,
  shadowUrl: iconShadow,
  iconAnchor: [16, 37],
});

L.Marker.prototype.options.icon = DefaultIcon;

export default function Mapa(props: MapaProps) {
  const [coordenadas, setCoordenadas] = useState<coordenadaDto[]>(
    props.coordenadas
  );

  return (
    <div style={{ marginBottom: "1rem" }}>
      <MapContainer
        center={
          props.coordenadas && props.coordenadas.length > 0
            ? [props.coordenadas[0].lat, props.coordenadas[0].lng]
            : [40.4430227, -3.8066413]
        }
        zoom={10}
        style={{ height: props.height }}
      >
        <TileLayer
          attribution="React Peliclas"
          url="https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png"
        />
        {props.soloLectura ? null : (
          <ClickMapa
            setPunto={(coordenadas) => {
              setCoordenadas([coordenadas]);
              props.manejarClickMapa(coordenadas);
            }}
          />
        )}
        {coordenadas.map((coordenada) => (
          <Marcador
            key={coordenada.lat + coordenada.lng}
            lng={coordenada.lng}
            lat={coordenada.lat}
          />
        ))}
      </MapContainer>
    </div>
  );
}

function ClickMapa(props: clickMapaProps) {
  useMapEvent("click", (e) => {
    props.setPunto({ lat: e.latlng.lat, lng: e.latlng.lng });
  });
  return null;
}

interface clickMapaProps {
  setPunto(coordenadas: coordenadaDto): void;
}

function Marcador(props: coordenadaDto) {
  return (
    <Marker position={[props.lat, props.lng]}>
      {props.nombre ? <Popup>{props.nombre}</Popup> : null}
    </Marker>
  );
}

interface MapaProps {
  height: string;
  coordenadas: coordenadaDto[];
  manejarClickMapa(coordenadas: coordenadaDto): void;
  soloLectura: boolean;
}
