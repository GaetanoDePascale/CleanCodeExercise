// Bad Code
class UserService {
    private userRepository: any;

    constructor() {
        this.userRepository = new UserRepository();
    }

    getUsers() {
        return this.userRepository.getUsers();
    }

    addUser(user) {
        return this.userRepository.addUser(user);
    }
}

class UserRepository {
    getUsers() {
        // recupera gli utenti dal database
    }

    addUser(user) {
        // aggiunge l'utente al database
    }
}
