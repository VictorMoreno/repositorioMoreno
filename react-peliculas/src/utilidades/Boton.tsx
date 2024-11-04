import { CSSProperties } from "react";

export default function Boton(props: botonProps) {
  return (
    <button
      type={props.type}
      className={props.className}
      onClick={props.onClick}
      style={props.style}
      disabled={props.disable}
    >
      {props.children}
    </button>
  );
}

interface botonProps {
  children: React.ReactNode;
  onClick?(): void;
  type: "button" | "submit";
  disable: boolean;
  className: string;
  style: CSSProperties
}

Boton.defaultProps = {
  type: "button",
  disable: false,
  className: 'btn btn-primary',
  style : null
};
