import { EventType } from "../eventType/EventType";
import { JsonValue } from "type-fest";

export type Event = {
  createdAt: Date;
  dateTime: Date | null;
  eventType?: EventType | null;
  id: string;
  updatedAt: Date;
  value: JsonValue;
};
