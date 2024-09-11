import { UserType } from "../Enums/user-type";

export interface User {
    
    id: number;
    userName: string;
    email: string;
    name: string;
    password: string;
    isAdmin: boolean;
    isBlocked: boolean;
    user : UserType;
}
 export class  User{

    constructor() {
        this.id = 0;
        this.userName = '';
        this.email = '';
        this.name = '';
        this.password = '';
        this.isAdmin = false;
        this.isBlocked = false;
        this.user = UserType.Agent;
      }
 }