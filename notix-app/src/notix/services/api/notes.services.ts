import http from "../core/http.common";

class NoteService {
  listAllNotes() {
    return http.get("/note/all");
  }
}

export default new NoteService();