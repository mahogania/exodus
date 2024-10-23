import { Association } from "../association/Association";
import { JsonValue } from "type-fest";

export type AssociationType = {
  associations?: Array<Association>;
  createdAt: Date;
  id: string;
  schema: JsonValue;
  updatedAt: Date;
};
