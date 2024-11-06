import { useFormikContext } from "formik";
import { coordenadaDto } from "./coordenada.module";
import Mapa from "./Mapa";

export default function FormularioMapa(props: formularioMapaProps) {
  const { values } = useFormikContext<any>();
  function actualizarCampos(coordenadas: coordenadaDto) {
    values[props.campoLat] = coordenadas.lat;
    values[props.campoLng] = coordenadas.lng;
  }

  return (
    <Mapa
      coordenadas={props.coordenadas}
      manejarClickMapa={actualizarCampos}
      height={"500px"}
      soloLectura={false}
    />
  );
}

interface formularioMapaProps {
  coordenadas: coordenadaDto[];
  campoLat: string;
  campoLng: string;
}