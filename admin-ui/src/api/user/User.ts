import { JsonValue } from "type-fest";

export type User = {
  id: string;
  username: string;
  roles: JsonValue;
};
