import { Event } from "../event/Event";
import { ObjectType } from "../objectType/ObjectType";
import { JsonValue } from "type-fest";

export type EventType = {
  createdAt: Date;
  events?: Array<Event>;
  id: string;
  objectTypes?: Array<ObjectType>;
  schema: JsonValue;
  updatedAt: Date;
};
