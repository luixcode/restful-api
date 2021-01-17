# restful-api
RESTful API demo built with ASP.NET Core

* How to validate data
* How to work with the HTTP PATCH method
* How to create custom validation attributes
* Document and explore Web Services

### swagger-json
```json
// http://localhost:5000/swagger/v1/swagger.json

{
  "openapi": "3.0.1",
  "info": {
    "title": "The Elephant API",
    "description": "A simple example ASP.NET Core Web API",
    "contact": {
      "name": "luixcode",
      "url": "https://github.com/luixcode"
    },
    "version": "v1"
  },
  "paths": {
    "/api/Elephants": {
      "get": {
        "tags": [
          "Elephants"
        ],
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      },
      "post": {
        "tags": [
          "Elephants"
        ],
        "requestBody": {
          "content": {
            "application/json-patch+json": {
              "schema": {
                "$ref": "#/components/schemas/ElephantTargetBinding"
              }
            },
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/ElephantTargetBinding"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/ElephantTargetBinding"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/ElephantTargetBinding"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/Elephants/{id}": {
      "get": {
        "tags": [
          "Elephants"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "path",
            "required": true,
            "schema": {
              "type": "integer",
              "format": "int32"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success"
          },
          "404": {
            "description": "Not Found",
            "content": {
              "text/plain": {
                "schema": {
                  "$ref": "#/components/schemas/ProblemDetails"
                }
              },
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ProblemDetails"
                }
              },
              "text/json": {
                "schema": {
                  "$ref": "#/components/schemas/ProblemDetails"
                }
              }
            }
          }
        }
      },
      "delete": {
        "tags": [
          "Elephants"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "path",
            "required": true,
            "schema": {
              "type": "integer",
              "format": "int32"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success"
          },
          "404": {
            "description": "Not Found",
            "content": {
              "text/plain": {
                "schema": {
                  "$ref": "#/components/schemas/ProblemDetails"
                }
              },
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ProblemDetails"
                }
              },
              "text/json": {
                "schema": {
                  "$ref": "#/components/schemas/ProblemDetails"
                }
              }
            }
          }
        }
      },
      "patch": {
        "tags": [
          "Elephants"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "path",
            "required": true,
            "schema": {
              "type": "integer",
              "format": "int32"
            }
          }
        ],
        "requestBody": {
          "content": {
            "application/json-patch+json": {
              "schema": {
                "type": "array",
                "items": {
                  "$ref": "#/components/schemas/Operation"
                },
                "nullable": true
              }
            },
            "application/json": {
              "schema": {
                "type": "array",
                "items": {
                  "$ref": "#/components/schemas/Operation"
                },
                "nullable": true
              }
            },
            "text/json": {
              "schema": {
                "type": "array",
                "items": {
                  "$ref": "#/components/schemas/Operation"
                },
                "nullable": true
              }
            },
            "application/*+json": {
              "schema": {
                "type": "array",
                "items": {
                  "$ref": "#/components/schemas/Operation"
                },
                "nullable": true
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success"
          },
          "404": {
            "description": "Not Found",
            "content": {
              "text/plain": {
                "schema": {
                  "$ref": "#/components/schemas/ProblemDetails"
                }
              },
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ProblemDetails"
                }
              },
              "text/json": {
                "schema": {
                  "$ref": "#/components/schemas/ProblemDetails"
                }
              }
            }
          }
        }
      }
    }
  },
  "components": {
    "schemas": {
      "ElephantTargetBinding": {
        "required": [
          "affiliation",
          "name",
          "species"
        ],
        "type": "object",
        "properties": {
          "name": {
            "type": "string"
          },
          "affiliation": {
            "type": "string"
          },
          "species": {
            "type": "string"
          },
          "sex": {
            "type": "string",
            "nullable": true
          }
        },
        "additionalProperties": false
      },
      "ProblemDetails": {
        "type": "object",
        "properties": {
          "type": {
            "type": "string",
            "nullable": true
          },
          "title": {
            "type": "string",
            "nullable": true
          },
          "status": {
            "type": "integer",
            "format": "int32",
            "nullable": true
          },
          "detail": {
            "type": "string",
            "nullable": true
          },
          "instance": {
            "type": "string",
            "nullable": true
          }
        },
        "additionalProperties": {
          
        }
      },
      "OperationType": {
        "enum": [
          0,
          1,
          2,
          3,
          4,
          5,
          6
        ],
        "type": "integer",
        "format": "int32"
      },
      "Operation": {
        "type": "object",
        "properties": {
          "operationType": {
            "$ref": "#/components/schemas/OperationType"
          },
          "path": {
            "type": "string",
            "nullable": true
          },
          "op": {
            "type": "string",
            "nullable": true
          },
          "from": {
            "type": "string",
            "nullable": true
          },
          "value": {
            "nullable": true
          }
        },
        "additionalProperties": false
      }
    }
  }
}
```
