export interface claim {
  nombre: string;
  valor: string;
}

export interface credencialesUsuario{
  email:string;
  password:string;
}

export interface respuestaAutenticacion{
  token: string;
  expiracion:Date;
}

export interface usuarioDto{
  id: string;
  email: string;
}
export interface restablecerCredencial{  
  password:string;
  passwordRepetida:string;
}
