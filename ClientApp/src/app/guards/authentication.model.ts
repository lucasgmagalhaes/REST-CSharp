export interface Authentication {
    authenticated: boolean;
    created: Date;
    expiration: Date;
    accessToken: string;
    message: string;
    idUsuario: number;
}
