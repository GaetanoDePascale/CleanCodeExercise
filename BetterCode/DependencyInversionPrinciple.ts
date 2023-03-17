// Better Code
class UserService {
    private userRepository: any;

    constructor(userRepository) {
        this.userRepository = userRepository;
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

const userRepository = new UserRepository();
const userService = new UserService(userRepository);
