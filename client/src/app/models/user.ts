import { UserRole } from "./userRole";

export interface User {
    id: number;
    userName: string;
    email: string;
    roles: UserRole[];
}