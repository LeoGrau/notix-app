export default class Note {
  constructor(private _id: number, private _title: string, private _description: string) {}
  public get title() { return this._title; }
  public get id() { return this._id; }
  public get description() { return this._description; }
  public set title(title: string) { this._title = title; }
  public set id(id: number) { this._id = id; }
  public set description(description: string) { this._description = description; }
}